#pragma target 2.0

#include "UnityCG.cginc"
#include "UnityUI.cginc"

struct appdata_t
{
    float4 vertex : POSITION;
    float4 color : COLOR;
    float2 texcoord : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct v2f
{
    float4 vertex : SV_POSITION;
    fixed4 color : COLOR;
    float2 texcoord : TEXCOORD0;
    float4 worldPosition : TEXCOORD1;
    half4  mask : TEXCOORD2;
    UNITY_VERTEX_OUTPUT_STEREO
};

sampler2D _MainTex;
fixed4 _TextureSampleAdd;
float4 _ClipRect;
float4 _MainTex_ST;
float _UIMaskSoftnessX;
float _UIMaskSoftnessY;

v2f vert(appdata_t v)
{
    v2f OUT;
    UNITY_SETUP_INSTANCE_ID(v);
    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
    OUT.worldPosition = v.vertex;
    OUT.vertex = UnityObjectToClipPos(OUT.worldPosition);

    float2 pixelSize = v.vertex.w;
    pixelSize /= float2(1, 1) * abs(mul((float2x2)UNITY_MATRIX_P, _ScreenParams.xy));

    float4 clampedRect = clamp(_ClipRect, -2e10, 2e10);
    OUT.mask = half4(v.vertex.xy * 2 - clampedRect.xy - clampedRect.zw,
                     0.25 / (0.25 * half2(_UIMaskSoftnessX, _UIMaskSoftnessY) + abs(pixelSize.xy)));

    OUT.texcoord = TRANSFORM_TEX(v.texcoord.xy, _MainTex);

    OUT.color.a = v.color.a;
    OUT.color.rgb = v.color.rgb * v.color.a;

    return OUT;
}

fixed4 frag(v2f IN) : SV_Target
{
    float4 color = (tex2D(_MainTex, IN.texcoord) + _TextureSampleAdd) * IN.color;

    #ifdef UNITY_UI_CLIP_RECT
    half2 m = saturate((_ClipRect.zw - _ClipRect.xy - abs(IN.mask.xy)) * IN.mask.zw);
    color *= m.x * m.y;
    #endif

    #ifdef UNITY_UI_ALPHACLIP
    clip (color.a - 0.001);
    #endif

    #ifdef DO_BLEND_POSTPROCESS
    DO_BLEND_POSTPROCESS
    #endif

    return color;
}
