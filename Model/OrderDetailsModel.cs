#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;

namespace SelectionDemo
{
    public class OrderDetails:INotifyPropertyChanged
    {

        private DateTime _orderDate;
        public DateTime OrderDate
        {
            get
            {
                return this._orderDate;
            }

            set
            {
                this._orderDate = value;
                this.RaisePropertyChanged("OrderDate");
            }
        }

        private bool? _isClosed;
        public bool? IsClosed
        {
            get
            {
                return this._isClosed;
            }

            set
            {
                this._isClosed = value;
                this.RaisePropertyChanged("IsClosed");
            }
        }
        private System.Nullable<int> _OrderID;

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        public System.Nullable<int> OrderID
        {
            get 
            {
                return this._OrderID; 
            }
            set
            {
                this._OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        private string _shipCity;
        /// <summary>
        /// Gets or sets the shipCityID.
        /// </summary>
        /// <value>The ship city ID.</value>
        public string ShipCity
        {
            get
            {
                return _shipCity;
            }
            set
            {
                _shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }
        /// <summary>
        /// Gets or sets the noOfOrders.
        /// </summary>
        /// <value>The no of orders.</value>
        private int _noOfOrders;
        public int NoOfOrders
        {
            get
            {
                return _noOfOrders;
            }
            set
            {
                _noOfOrders = value;
                RaisePropertyChanged("NoOfOrders");
            }
        }
        /// <summary>
        /// Gets or sets the customerID.
        /// </summary>
        /// <value>The customer ID.</value>
        private string _customerID;
        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }
        
        private string _productName;

        /// <summary>
        /// Gets or sets the productName.
        /// </summary>
        /// <value>The product name.</value>
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                RaisePropertyChanged("ProductName");
            }
        }
        
        private string _shipCountry;

        /// <summary>
        /// Gets or sets the shipCounry.
        /// </summary>
        /// <value>The ship counry.</value>
        public string ShipCountry
        {
            get
            {
                return _shipCountry;
            }
            set
            {
                _shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetails"/> class.
        /// </summary>
        /// <param name="ord">The ord.</param>
        /// <param name="cusid">The custmer iD.</param>
        /// <param name="productName">The product name.</param>
        /// <param name="NoOfOrders">The no of orders.</param>
        /// <param name="country">The country.</param>
        /// <param name="ShipCity">The ship city ID.</param>
        public OrderDetails(int ord, string cusid, string productName, int NoOfOrders,string country,string shipCity,bool? isClosed,DateTime orderDate)
        {
            this._OrderID = ord;
            this._customerID = cusid;
            this._shipCountry = country;
            this._shipCity = shipCity;
            this._productName = productName;
            this._noOfOrders = NoOfOrders;
            this._isClosed = isClosed;
            this._orderDate = orderDate;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
