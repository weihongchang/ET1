using System;
using UnityEngine.SceneManagement;

namespace ET.Client
{
    [Event(SceneType.Demo)]
    public class SceneChangeStart_AddComponent: AEvent<Scene, SceneChangeStart>
    {
        protected override async ETTask Run(Scene root, SceneChangeStart args)
        {
            try
            {
                Scene currentScene = root.CurrentScene();

                ResourcesLoaderComponent resourcesLoaderComponent = currentScene.GetComponent<ResourcesLoaderComponent>();
            
                // 加载场景资源 不需要相对地址了，YooAsset只需要文件名Key
                await resourcesLoaderComponent.LoadSceneAsync(currentScene.Name, LoadSceneMode.Single);
                //await resourcesLoaderComponent.LoadSceneAsync($"Assets/Bundles/Scenes/{currentScene.Name}.unity", LoadSceneMode.Single);
                // 切换到map场景

                //await SceneManager.LoadSceneAsync(currentScene.Name);

                currentScene.AddComponent<OperaComponent>();
            }
            catch (Exception e)
            {
                Log.Error(e);
            }

        }
    }
}