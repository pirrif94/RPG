using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateCharacter : MonoBehaviour {
    int rnd1,rnd2,rnd3,rnd4;
    public static int Str, Agi, Intel, Skl, Hp, Mp;
    static float Dodge, Ms, AtkSpd, Melee, Ranged, Magic, Mdef, Pdef, Mreg, HPreg, AccuracyMelee, AccuracyRanged,AccuracyMagick;
    static string Class, Rase = "Empty";
    public Text Stats1,Stats2,Stats3,Stats4;
    public GameObject button1, button2, button3, text, button4,button5,button6,button7,button8,text2,text3,text4,text5,text6, hero, stats;
    private bool Chosen = false;

    public void randomik()
    {
        rnd1 = Random.Range(-2, 3);
        rnd2 = Random.Range(-2, 3);
        rnd3 = Random.Range(-2, 3);
        rnd4 = Random.Range(-2, 3);
    }

    public void create()
    {
        Str += rnd1;
        Agi += rnd2;
        Intel += rnd3;
        Skl += rnd4;
        Chosen = true;
        button7.SetActive(false);
        button8.SetActive(false);
        hero.SetActive(true);
    }

    void Start ()
    {
        randomik();
    }
	
    void printstats()
    {
        if (!Chosen)
        {
            Stats1.text = "Сила: " + Str + " (" + rnd1 + ")";
            Stats2.text = "Ловкость: " + Agi + " (" + rnd2 + ")";
            Stats3.text = "Интелект: " + Intel + " (" + rnd3 + ")";
            Stats4.text = "Талантливость: " + Skl + " (" + rnd4 + ")";
        }
        else
        {
            Stats1.text = "Сила: " + Str;
            Stats2.text = "Ловкость: " + Agi;
            Stats3.text = "Интелект: " + Intel;
            Stats4.text = "Талантливость: " + Skl;
        }

    }

	void Update ()
    {
        printstats();
        if (Input.GetKeyDown(KeyCode.Tab))
            stats.active = !stats.active;

    }

    void PickRase(string rase, int str, int agi, int intel, int skl, int hp, int mp, float mreg, float hpreg, float ms)
    {
        Rase = rase; Str = str; Agi = agi; Intel = intel; Skl = skl; Hp = hp; Mp = mp; Mreg = mreg; HPreg = hpreg; Ms = ms;
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        text.SetActive(true);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        text2.SetActive(false);
    }

    public void Human()
    {
        PickRase("Human", 5, 5, 5, 5, 20, 20, 1, 1, 100);
    }

    public void Orc()
    {
        PickRase("Orc", 6, 4, 3, 3, 30, 15, 0, 2, 110);
    }

    public void Elf()
    {
        PickRase("Elf", 4, 6, 5, 4, 15, 25, 2, 0, 125);
    }

    void PickClass(string clas,int hp,int mp, float dodge,float atkSpd,float melee,float ranged,float magic,float accuracyMelee,float accuracyRanged,float accuracyMagick)
    {
        if (Rase != "Empty")
        {
            Class = clas; Hp += hp; Mp += mp; Dodge = dodge; AtkSpd = atkSpd; Melee = melee; Ranged = ranged; Magic = magic; AccuracyMelee = accuracyMelee;
            AccuracyRanged = accuracyRanged; AccuracyMagick = accuracyMagick;
            text3.SetActive(true);
            text4.SetActive(true);
            text5.SetActive(true);
            text6.SetActive(true);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            text.SetActive(false);
            button7.SetActive(true);
            button8.SetActive(true);
        }
    }

    public void Warrior()
    {
        PickClass("Warrior", 2, 0, 2, 0.8f, 3, 2, 1, 3, 2, 1);
    }

    public void Mage()
    {
        PickClass("Mage", 0, 2, 0, 0.5f, 1, 1, 3, 1, 1, 3);
    }

    public void Archer()
    {
        PickClass("Archer", 1, 0, 4, 0.8f, 2, 3, 1, 2, 3, 1);
    }
}
