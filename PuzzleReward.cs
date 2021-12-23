using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleReward : MonoBehaviour
{
    public Text button1Text;
    // Start is called before the first frame update

    public void Button1Info()
    {
        button1Text.text = "Tribal people in the Baliem valley of New Guinea probably developed agriculture long before the ancestors of Europeanstt.\n Hadza hunters in Tanzania use the song of an African bird to guide them to bees’ nests in baobab trees";
    }
    public void Button2Info()
    {
        button1Text.text = "The Bhil tribe is found mostly in the central and western parts of India. Till the early 20th century, the Bhil people served as warriors for the kings because of their impeccable knowledge of the terrain. Since then they have settled in villages. The Ghoomar, which is a traditional folk dance of Rajasthan, was developed by the Bhil tribe. Interestingly, during marriages it is the men who have to pay a dowry of sorts (10 goats) to be able to marry an eligible woman!";
    }
    public void Button3Info()
    {
        button1Text.text = "Tribal peoples developed some of the world’s staple foods. Manioc (cassava), maize and potatoes are all the product of indigenous husbandry.\n The Sentinelese tribe is thought to have lived on the Andaman Islands for about 55,000 years.";
    }
}
