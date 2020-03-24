using Newtonsoft.Json;
using System;
using System.IO;

namespace RadioWPFApp
{
    public class Radio
    {

        // Priviate initialisation

        private int _channel = 1;
        private bool _on = false;
        private int _volume;
        string path = @"C:\Users\TECH-W154birm\Downloads\RadioWPF\RadioWPF\data.json";

      
        public int Channel
        { /// get set property
            get { return _channel; }
            set
            {
                if (value >= 1 && value <= 4 && _on == true)
                {
                    _channel = value;
                }

            }

        }


        // Read channel method

        public int ChannelRead
        {
            get { return _channel; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    _channel = value;
                }
            }

        }

        
        // VOLUME method implemented 
        public int Volume
        {
            get { return _volume; }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _volume = value;
                }
            }

        }

        // READ Volume method
        public int VolumeRead
        {
            get { return _volume; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _volume = value;
                }
            }
        }

       

        // PLAY method used if ON displays "Playing Channel ..." or else OFF
        public string Play()
        {


            if (_on == true)
            {
                return $"Playing channel {_channel}";
            }
            else
            {
                return "radio is off";
            }

        }


        // TURN OFF METHOD 

        public void TurnOff()
        {
            _on = false;

        }


        // TURN ON METHOD
        public void TurnOn()
        {
            _on = true;
        }


        public void Write()
        {

            _channel = ChannelRead;
            _volume = VolumeRead;
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, output);
        }



        public void Read()
        {

            string jsonfile = File.ReadAllText(path);
            Radio deSerialised = JsonConvert.DeserializeObject<Radio>(jsonfile);
            ChannelRead = deSerialised.ChannelRead;
            VolumeRead = deSerialised.VolumeRead;
            
        }




    }

    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the INSTRUCTIONS document in this solution   
}