using System.Collections;
using Kimicu.YandexGames;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Scripts
{
    public class Boot : MonoBehaviour
    {
        private IEnumerator Start()
        {
            yield return YandexGamesSdk.Initialize();
            Advertisement.Initialize();
            WebApplication.Initialize(null);

            LoadScene();
            Advertisement.ShowInterstitialAd();
        }


        private void LoadScene() => SceneManager.LoadScene(1);
    }
}