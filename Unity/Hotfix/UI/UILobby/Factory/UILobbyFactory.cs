﻿using System;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
    [UIFactory((int)UIType.UILobby)]
    public class UILobbyFactory : IUIFactory
    {
        public UI Create(Scene scene, int type, GameObject gameObject)
        {
	        try
	        {
		        string uiName = UIType.GetUIName(type);
				ResourcesComponent resourcesComponent = ETModel.Game.Scene.GetComponent<ResourcesComponent>();
		        resourcesComponent.LoadBundle($"{uiName}.unity3d");
				GameObject bundleGameObject = resourcesComponent.GetAsset<GameObject>($"{uiName}.unity3d", $"{uiName}");
				GameObject lobby = UnityEngine.Object.Instantiate(bundleGameObject);
				lobby.layer = LayerMask.NameToLayer(LayerNames.UI);
				UI ui = ComponentFactory.Create<UI, GameObject>(lobby);

				ui.AddComponent<UILobbyComponent>();
				return ui;
	        }
	        catch (Exception e)
	        {
				Log.Error(e.ToStr());
		        return null;
	        }
		}

	    public void Remove(int type)
	    {
		    string uiName = UIType.GetUIName(type);
			ETModel.Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle($"{uiName}.unity3d");
		}
    }
}