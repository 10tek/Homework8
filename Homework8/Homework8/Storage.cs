using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework8
{
    abstract public class Storage
    {
        private string _carrierName;
        private string _carrierModel;
        public int GlobalMemory { get; set; }
        public int FreeMemory { get; set; }
        public int OccupiedMemory { get; set; }

        public Storage(string carrierName, string carrierModel)
        {
            _carrierModel = carrierModel;
            _carrierName = carrierName;
        }

        public abstract int CopyData(params int[] datas);
        public abstract string GetInfo();
    }
}