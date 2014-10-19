﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using EnhancedEntities;

namespace EnhancedDataAccess
{
    public partial class EnhancedEntities : ObjectContext
    {
        public const string ConnectionString = "name=EnhancedEntities";
        public const string ContainerName = "EnhancedEntities";
    
        #region Constructors
    
        public EnhancedEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public EnhancedEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public EnhancedEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Category> Categories
        {
            get { return _categories  ?? (_categories = CreateObjectSet<Category>("Categories")); }
        }
        private ObjectSet<Category> _categories;
    
        public ObjectSet<OrderDetail> OrderDetails
        {
            get { return _orderDetails  ?? (_orderDetails = CreateObjectSet<OrderDetail>("OrderDetails")); }
        }
        private ObjectSet<OrderDetail> _orderDetails;
    
        public ObjectSet<OrderHeader> OrderHeaders
        {
            get { return _orderHeaders  ?? (_orderHeaders = CreateObjectSet<OrderHeader>("OrderHeaders")); }
        }
        private ObjectSet<OrderHeader> _orderHeaders;
    
        public ObjectSet<Product> Products
        {
            get { return _products  ?? (_products = CreateObjectSet<Product>("Products")); }
        }
        private ObjectSet<Product> _products;

        #endregion
    }
}