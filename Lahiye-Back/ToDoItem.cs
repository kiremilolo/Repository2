using Lahiye_Back;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lahiye_Back
{
   public  class ToDoItem



    {
        public int No;
        public Status status;
        public string Title;
        public string Description;
        public DateTime? DeadLine= null;
        public DateTime StatusChangedAt;
        public static int Counter;


        public ToDoItem()
        {
            Counter++;
            No = Counter;
        }
        

       
    }

}



