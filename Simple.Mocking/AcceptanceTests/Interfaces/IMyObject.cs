﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Simple.Mocking.AcceptanceTests.Classes;

namespace Simple.Mocking.AcceptanceTests.Interfaces
{
	public interface IMyObject
	{	
		void MyEmptyMethod();

		void MyMethod(int value);

		void MyMethod(ABaseClass value);

		int MyMethodWithReturnValue(int value);

		int MyMethodWithOutParameter(int inValue, out int outValue);

		void MyMethodWithRefParameter(ref int value);

		void MyMethodWithInterfaceParameter(IComparable<int> value);

		void MyMethodWithOverload(int value);

		void MyMethodWithOverload(string value);

		T MyGenericMethod<T>(T value);

		object MyProperty { get; set; }

		object this[int i] { get; set; }

		event EventHandler MyEvent;
	}
}
