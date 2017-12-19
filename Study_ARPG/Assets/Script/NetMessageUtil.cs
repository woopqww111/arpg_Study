﻿using System.Collections;
using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class NetMessageUtil : MonoBehaviour
{
    private IHandler login;
	// Use this for initialization
	void Start ()
	{
	    login = GetComponentInChildren<LoginHandler>();
	}
	
	// Update is called once per frame
	void Update () {
	    while (NetIO.Instance.messages.Count > 0)
	    {
	        SocketModel model = NetIO.Instance.messages[0];
	        StartCoroutine("MessageReceive", model);
	        NetIO.Instance.messages.RemoveAt(0);
	    }
		
	}

    void MessageReceive(SocketModel model)
    {
        switch (model.type)
        {
            case Protocol.TYPE_LOGIN:
                login.MessageReceive(model);
                break;
        }
    }
}
