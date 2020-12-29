using System;
using System.Collections.Generic;
using System.Text;

namespace MQTTRepeater.Model
{
    public class ParamData
    {
        public long paramID = 0;
        public double currentValue = 0;
        public DateTime saveTime;
        public int paramTemp = 0;
        public string paramName = "";
    }
    public class ParamGPIO
    {
        public string GPIOName = "";
        public int Enable = 0;
        public int SetValue = 0;
        public double StartTemp = 0;
        public double StopTemp = 0;
        public double StartHum = 0;
        public double StopHum = 0;
        public DateTime SaveTime;
        public int GPIOTemp = 0;
        public int GPIONum = 0;
        public int DelayTime = 0;
        public int ControlStyle = 0;

    }
    public class ParamTimer
    {
        public string TimerName = "";
        public int Enable = 0;
        
        public double StartTime = 0;
        public double StopTime = 0;
        
        public DateTime SaveTime;
        public int GPIONum = 0;
      

    }
}
