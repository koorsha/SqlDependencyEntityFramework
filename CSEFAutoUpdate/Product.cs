﻿/****************************** Module Header ******************************\
Module Name:  Product.cs
Project:      CSEFAutoUpdate
Copyright (c) Microsoft Corporation.

We can use the Sqldependency to get the notification when the data is changed 
in database, but EF doesn’t have the same feature. In this sample, we will 
demonstrate how to automatically update by Sqldependency in Entity Framework.
In this sample, we will demonstrate two ways that use SqlDependency to get the 
change notification to auto update data.
It's the entity class used in EF.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/en-us/openness/licenses.aspx#MPL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;

namespace CSEFAutoUpdate
{
    public class Product
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public double Amount { get; set; }
    }
}
