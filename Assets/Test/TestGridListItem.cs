﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NSUListView;

public class TestGridListItem : MonoBehaviour
{
	//public USimpleListView listView;
	public UGridListView listView;

	void Start()
	{
		List<object> lstData = new List<object> ();
		for (int i=0; i<100; ++i) {
			lstData.Add (i);
		}
		listView.SetData (lstData);
	}
}