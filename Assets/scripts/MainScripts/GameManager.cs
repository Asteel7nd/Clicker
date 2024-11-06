using UnityEngine;
using UnityEngine.UI;


namespace Asteel7nd
{
    public sealed class GameManager : MonoBehaviour
    {
        [SerializeField] private int score;
        [SerializeField] private int click = 1;
        [SerializeField] private int upgradeClick = 10;
        [SerializeField] private int lvl = 0;


        [SerializeField] private Text scoreText;
        [SerializeField] private Text upgradeText;
        [SerializeField] private Text lvlText;


        public GameObject[] Money;
        public Transform SpownPosition;


        private void Update()
        {
            scoreText.text = score.ToString();
            upgradeText.text = upgradeClick.ToString();
            lvlText.text = lvl.ToString();
        }

        public void Click()
        {
            score += click;
            Instantiate(Money[Random.Range(0, 5)], SpownPosition.position, Quaternion.identity);           
        }

        public void UpgradeClick()
        {
            if (score >= upgradeClick)
            {
                score -= upgradeClick;
                upgradeClick += upgradeClick + 10;
                click++;
                lvl++;
            }
            else Debug.Log("u have no money");
        }
    }
}
