﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XForms.Toolkit.Sample
{	
	public partial class AutoCompletePage : ContentPage
	{	
		public AutoCompletePage ()
		{
			InitializeComponent ();
			BindingContext = ViewModelLocator.Main;
		}
	}
}

