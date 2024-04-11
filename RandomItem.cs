using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RandomItem : MonoBehaviour
{
    List<Item> itemList;

    void Start()
    {
        itemList = new List<Item>();

        itemList.Add(new Item("상의", "방어력을 10 올려줍니다.", Resources.Load<Sprite>("Armor")));
        itemList.Add(new Item("장갑", "방어력을 3 올려줍니다.", Resources.Load<Sprite>("Glove")));
        itemList.Add(new Item("신발", "방어력을 5 올려줍니다.", Resources.Load<Sprite>("Shoes")));
        itemList.Add(new Item("모자", "방어력을 8 올려줍니다.", Resources.Load<Sprite>("Helmet")));
    }

    public void SelectBox()
    {
        List<Item> items = itemList.ToList();

        for (int i = 0; i < 200; i++)
        {
            int ran1 = Random.Range(0, items.Count);
            int ran2 = Random.Range(0, items.Count);

            Item temp = items[ran1];
            items[ran1] = items[ran2];
            items[ran2] = temp;
        }

        Item slectedItem = items[0];
        Debug.Log($"{slectedItem.name.ToString()} 가 뽑혔습니다.");
    }
}
