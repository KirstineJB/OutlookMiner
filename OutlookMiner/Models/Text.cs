﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class Text
    {
        public string body { get; set; }
        public string threadID { get; set; }
        public string sender { get; set; }
        public string senderEmail { get; set; }
        public DateTime recievedTime { get; set; }
        public List<string> recipients { get; set; } = new List<string>();




        public Text(string _body, string _threadID)
        {
            this.body = _body;
            this.threadID = _threadID;
        }
    }
}
