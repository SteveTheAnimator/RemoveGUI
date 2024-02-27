using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using UnityEngine.SceneManagement;

namespace RemoveGUI
{
    public class Plugin : MelonMod
    {
        public GameObject Canavs;
        public GameObject Camera;
        public GameObject POSTPRO;

        public override void OnUpdate()
        {
            // Get the current active scene
            Scene currentScene = SceneManager.GetActiveScene();

            // Check if the scene name is "SampleScene"
            if (currentScene.name == "SampleScene")
            {
                Canavs = GameObject.Find("Player/CameraPivot/Main Camera/Canvas/");
                Canavs.SetActive(false);

                Camera = GameObject.Find("Player/CameraPivot/Main Camera/");
                UnityEngine.Object.Destroy(Camera.GetComponent<Kino.AnalogGlitch>());
                UnityEngine.Object.Destroy(Camera.GetComponent<JetFistGames.RetroTVFX.CRTEffect>());

                POSTPRO = GameObject.Find("POSTPRO/");
                POSTPRO.SetActive(false);
            }
            if (currentScene.name == "SuperSecret")
            {
                Camera = GameObject.Find("Main Camera (1)/");
                UnityEngine.Object.Destroy(Camera.GetComponent<Kino.AnalogGlitch>());
                UnityEngine.Object.Destroy(Camera.GetComponent<JetFistGames.RetroTVFX.CRTEffect>());
            }
        }
    }
}
