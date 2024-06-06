using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using UnityEngine;
using UnityEngine.Networking;

namespace Managers
{
    /// <summary>
    /// 这已经不是tts了, 只是买不起接口, 所以只能用这个来代替
    /// </summary>
    public class TtsManager : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audioSource;
        
        [SerializeField]
        private AudioClip leftAudioClip, rightAudioClip,
            number1AudioClip, number2AudioClip, number3AudioClip, number4AudioClip, number5AudioClip,
            number6AudioClip, number7AudioClip, number8AudioClip, number9AudioClip, number0AudioClip,
            startAudioClip, endAudioClip;
        
        public static TtsManager Instance { get; private set; }
        
        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            // 订阅队列改变事件
            QueueManager.Instance.OnLeftPassed.AddListener(OnLeftPassed);
            QueueManager.Instance.OnRightPassed.AddListener(OnRightPassed);
        }

        private async void OnLeftPassed()
        {
            await QueueManager.Instance.UpdateQueueItems();
            
            var next = QueueManager.Instance.GetNextQueueItem(false);
            if (next is null)
            {
                return;
            }

            var playerId = next.queueId;
            Debug.Log($"TTS: {playerId} 左侧");
            
            Speak(false, playerId.ToString());
        }
        
        private async void OnRightPassed()
        {
            await QueueManager.Instance.UpdateQueueItems();
            
            var next = QueueManager.Instance.GetNextQueueItem(true);
            if (next is null)
            {
                return;
            }
            
            var playerId = next.queueId;
            Debug.Log($"TTS: {playerId} 右侧");
            
            Speak(false, playerId.ToString());
        }

        private void Speak(bool isRight, string number)
        {
            if (currentCoroutine != null) StopCoroutine(currentCoroutine);

            var directionAudioClip = isRight ? rightAudioClip : leftAudioClip;
            var numberDigits = number.ToCharArray();
            var numberAudioClips = new AudioClip[numberDigits.Length].ToList();
            foreach (var digit in numberDigits)
            {
                Debug.Log(digit);

                switch (digit)
                {
                    case '1':
                        numberAudioClips.Add(number1AudioClip);
                        break;
                    case '2':
                        numberAudioClips.Add(number2AudioClip);
                        break;
                    case '3':
                        numberAudioClips.Add(number3AudioClip);
                        break;
                    case '4':
                        numberAudioClips.Add(number4AudioClip);
                        break;
                    case '5':
                        numberAudioClips.Add(number5AudioClip);
                        break;
                    case '6':
                        numberAudioClips.Add(number6AudioClip);
                        break;
                    case '7':
                        numberAudioClips.Add(number7AudioClip);
                        break;
                    case '8':
                        numberAudioClips.Add(number8AudioClip);
                        break;
                    case '9':
                        numberAudioClips.Add(number9AudioClip);
                        break;
                    case '0':
                        numberAudioClips.Add(number0AudioClip);
                        break;
                }
            }
            
            currentCoroutine = StartCoroutine(PlayAudioClips(directionAudioClip, numberAudioClips));
        }
        
        private Coroutine currentCoroutine;

        // Start - Direction - Number - End
        private IEnumerator PlayAudioClips(AudioClip directionAudioClip, List<AudioClip> numberAudioClips)
        {
            audioSource.clip = startAudioClip;
            audioSource.Play();
            yield return new WaitForSeconds(startAudioClip.length);
            
            audioSource.clip = directionAudioClip;
            audioSource.Play();
            yield return new WaitForSeconds(directionAudioClip.length);
            
            foreach (var numberAudioClip in numberAudioClips.Where(numberAudioClip => numberAudioClip is not null))
            {
                Debug.Log(numberAudioClip.name);
                audioSource.clip = numberAudioClip;
                audioSource.Play();
                yield return new WaitForSeconds(numberAudioClip.length);
            }
            
            audioSource.clip = endAudioClip;
            audioSource.Play();
            yield return new WaitForSeconds(endAudioClip.length);
        }


        private void Update()
        {
            if (Input.GetKeyDown("o"))
            {
                Speak(false, "1145140");
            }
        }
    }
}