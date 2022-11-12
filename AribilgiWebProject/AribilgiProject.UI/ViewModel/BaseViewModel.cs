﻿using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AribilgiProject.UI.ViewModel
{
    public class BaseViewModel<T> where T : BaseModel
    {
        public int ID { get; set; }
        public DateTime? DelDate { get; set; }
        public DateTime CreDate { get; set; }

        public BaseViewModel(T baseModel)
        {
            ID = baseModel.ID;
            DelDate = baseModel.DelDate;
            CreDate = baseModel.CreDate;
        }
    }
}