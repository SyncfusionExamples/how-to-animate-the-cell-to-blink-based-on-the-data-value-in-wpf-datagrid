#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SelectionDemo
{
    public class ViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.PopulateData();
        }

        private int selectedIndex= 5;
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
            }
        }
        private ObservableCollection<OrderDetails> _orderDatails;
        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderDetails> OrderDetails
        {
            get
            {
                return _orderDatails;
            }
            set
            {
                _orderDatails = value;
            }
        }

        
        Random r = new Random();
        public void PopulateData()
        {
            _orderDatails = new ObservableCollection<OrderDetails>();
            _orderDatails.Add(new OrderDetails(1000, CustomerID[r.Next(15)], ProductName[r.Next(6)], 10, "Argentina", "Bergamo", false,DateTime.Today));
            _orderDatails.Add(new OrderDetails(1001, CustomerID[r.Next(15)], ProductName[r.Next(6)], 15, "Austria", "Graz", true, new DateTime(2017, 9, 24)));
            _orderDatails.Add(new OrderDetails(1002, CustomerID[r.Next(15)], ProductName[r.Next(6)], 20, "Belgium", "Montréal", true, DateTime.Today));
            _orderDatails.Add(new OrderDetails(1003, CustomerID[r.Next(15)], ProductName[r.Next(6)], 25, "Brazil", "Liiie", null, DateTime.Today));
            _orderDatails.Add(new OrderDetails(1004, CustomerID[r.Next(15)], ProductName[r.Next(6)], 20, "Canada", "Montreal", null, new DateTime(2015, 9, 23)));
            _orderDatails.Add(new OrderDetails(1005, CustomerID[r.Next(15)], ProductName[r.Next(6)], 17, "Denmark", "Cork", false, DateTime.Today));
            _orderDatails.Add(new OrderDetails(1006, CustomerID[r.Next(15)], ProductName[r.Next(6)], 14, "Finland", "Aachen", null, DateTime.Today));
            _orderDatails.Add(new OrderDetails(1007, CustomerID[r.Next(15)], ProductName[r.Next(6)], 11, "Italy", "Archen", false, new DateTime(2017, 10, 23)));
            _orderDatails.Add(new OrderDetails(1008, CustomerID[r.Next(15)], ProductName[r.Next(6)], 7, "US", "Komba", true, new DateTime(2017, 1, 23)));
            _orderDatails.Add(new OrderDetails(1009, CustomerID[r.Next(15)], ProductName[r.Next(6)], 5, "Belgium", "Loolie", false, DateTime.Today));
            _orderDatails.Add(new OrderDetails(1010, CustomerID[r.Next(15)], ProductName[r.Next(6)], 3, "Brazil", "Helsinki", true, new DateTime(2000, 9, 23)));
        }
        string[] ProductName = new string[]
       {
            "Alice Mutton",
            "NuNuCa Nub-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute Semmelknodel",
            "Konbu"
       };
        string[] CustomerID = new string[]
      {
            "ALFKI",
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "BLONP",
            "WELLI",
            "FOLIG"
      };
    }
}
