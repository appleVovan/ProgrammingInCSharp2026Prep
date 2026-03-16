using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.Samples
{
    internal class MyBackgroudWorker
    {
        private Tuple<string, int, double> _inputPrams;
        private Tuple<string, bool> _outputPrams;

        private bool _isRunning = true;

        public Tuple<string, bool> OutputPrams { get { return _outputPrams; } }

        public MyBackgroudWorker(string param1, int param2, double param3)
        {
            _inputPrams = new Tuple<string, int, double>(param1, param2, param3);
        }

        public void Stop()
        {
            _isRunning = false;
        }

        public void Process()
        {
            var inputParams = _inputPrams;
            //Process inputParams
            while (_isRunning)
            {
                //Perform Step1
                if (!_isRunning)
                {
                    //End processing and step 2
                    break;
                }
                //Perform Step2
                if (!_isRunning)
                {
                    //End processing and step 3
                    break;
                }
                //Perform Step3
            }
            _outputPrams = new Tuple<string, bool>("Result", true);
        }
    }
        
}
