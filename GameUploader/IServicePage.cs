﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUploader
{
	interface IServicePage
	{
		void SetParentWindow(MainWindow window);
		string ServiceName { get; }
		void OnEntered();
		void OnExited();
	}
}
