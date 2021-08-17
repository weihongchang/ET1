﻿namespace ET
{
    public static class EntitySceneFactory
    {
        public static Scene CreateScene(long id, long instanceId, int zone, SceneType sceneType, string name, Entity parent = null)
        {
            Scene scene = new Scene(id, instanceId, zone, sceneType, name);
            scene.IsRegister = true;
            scene.Parent = parent;
            scene.Domain = scene;

            return scene;
        }

        public static Scene CreateScene(long instanceId, int zone, SceneType sceneType, string name, Entity parent = null)
        {
            Scene scene = new Scene(instanceId, zone, sceneType, name);
            scene.IsRegister = true;
            scene.Parent = parent;
            scene.Domain = scene;

            return scene;
        }

        public static Scene CreateScene(int zone, SceneType sceneType, string name, Entity parent = null)
        {
            long instanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene scene = new Scene(instanceId, zone, sceneType, name);
            scene.IsRegister = true;
            scene.Parent = parent;
            scene.Domain = scene;

            return scene;
        }
    }
}