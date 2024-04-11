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

        itemList.Add(new Item("����", "������ 10 �÷��ݴϴ�.", Resources.Load<Sprite>("Armor")));
        itemList.Add(new Item("�尩", "������ 3 �÷��ݴϴ�.", Resources.Load<Sprite>("Glove")));
        itemList.Add(new Item("�Ź�", "������ 5 �÷��ݴϴ�.", Resources.Load<Sprite>("Shoes")));
        itemList.Add(new Item("����", "������ 8 �÷��ݴϴ�.", Resources.Load<Sprite>("Helmet")));
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
        Debug.Log($"{slectedItem.name.ToString()} �� �������ϴ�.");
    }
}
