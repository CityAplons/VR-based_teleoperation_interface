/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Px4Control
{
    public class UnitySetStateRequest : Message
    {
        public const string RosMessageName = "px4_control/UnitySetState";

        //  Request constants
        public const sbyte LAND = 0;
        public const sbyte TAKEOFF = 1;
        public const sbyte HOVER = 2;
        public const sbyte POSCTL = 3;
        //  Request fields
        public sbyte set_state { get; set; }

        public UnitySetStateRequest()
        {
            this.set_state = 0;
        }

        public UnitySetStateRequest(sbyte set_state)
        {
            this.set_state = set_state;
        }
    }
}
