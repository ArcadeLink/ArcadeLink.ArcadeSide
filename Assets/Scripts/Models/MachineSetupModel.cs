namespace Models
{
    public class MachineSetupModel
    {
        public int leftMachineId { get; set; }
        public int rightMachineId { get; set; }
        
        public static MachineSetupModel DefaultLeftMachine()
        {
            return new MachineSetupModel
            {
                leftMachineId = 0,
                rightMachineId = -1
            };
        }
        
        public static MachineSetupModel DefaultRightMachine()
        {
            return new MachineSetupModel
            {
                leftMachineId = -1,
                rightMachineId = 0
            };
        }
        
        public static MachineSetupModel DefaultBothMachines()
        {
            return new MachineSetupModel
            {
                leftMachineId = 0,
                rightMachineId = 1
            };
        }
    }
}