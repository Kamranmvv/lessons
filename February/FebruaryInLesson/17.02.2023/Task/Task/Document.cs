using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Document
    {
        private int _documentNumber;
        private string _documentSerial;

        public int DocumentNumber
        {
            set
            {
                _documentNumber = value;
            }
            get
            {

                return 1;
            }
        }

        public string DocumentSerial
        {
            set
            {
                _documentSerial = value;
            }
            get
            {
                return _documentSerial;
            }
        }

    }
}
