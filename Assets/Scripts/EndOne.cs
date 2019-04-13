﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EndOne : MonoBehaviour
{
    private GameObject black;
    private GameObject image1;
    private GameObject image2;
    private GameObject image3;
    private GameObject text;
    private GameObject jingluo;
    private AudioSource Audio;
    private string word1 = "你敬仰生命的美好吗？\n你恐惧死亡的永恒吗？";
    private string word2 = "生命很短暂，庞大如鲸鱼也会在时间的作用下衰老、死亡，没有谁是永恒的。\n" +
        "但我们有理由相信，因为是面对死亡而出现，生命一定有巨大的勇气，于是生命才能够在时间的无情当中挣扎，不断地成长。\n" +
        "所以，这样一首勇气的赞歌的结尾必定不会是恐惧，面对死亡，用漫漫时光当中积累的所有勇气去打破这面墙壁。\n" +
        "于是便能够看到，墙壁的另一侧有无数的生命在庆贺着，终于，又有一个生命完美谢幕";
    private string word3 = "所以，你知道吗？" +
        "让一首勇气的赞歌提前结束的，往往是杂音。\n" +
        "是那些悬浮在海水中或沉积在淤泥里的杂音。\n" +
        "我们不知道Alice最终的结局是怎样的，仅仅是预想出了这样的压抑。";
    private string word4 = "如果在现实中做出改变\nAlice会不会能够有力气\n等到理解她的鲸出现呢？";
    private string word5 = "Thank You For Playing";
    // Start is called before the first frame update
    void Start()
    {
        black = transform.Find("black").gameObject;
        image1 = transform.Find("Image1").gameObject;
        image2 = transform.Find("Image2").gameObject;
        image3 = transform.Find("Image3").gameObject;
        text = transform.Find("Text").gameObject;
        jingluo = transform.Find("jingluo").gameObject;
        Audio = transform.GetComponent<AudioSource>();
        StartCoroutine("End");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  /*  IEnumerator end()
    {
        jingluo.GetComponent<Text>().DOFade(1, 2f);
        yield return new WaitForSeconds(3);
        jingluo.GetComponent<Text>().DOFade(0, 2f);
        yield return new WaitForSeconds(3);
        black.GetComponent<Image>().DOFade(0, 2f);
        Audio.Play();
        GameObject.Find("Main Camera").GetComponent<AudioSource>().volume = 0.6f;
        yield return new WaitForSeconds(5);
        black.GetComponent<Image>().DOFade(1, 2f);
        yield return new WaitForSeconds(3);
        text.GetComponent<Text>().text = GameManager.gameManager.we[0];
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(4);
        text.GetComponent<Text>().DOFade(0, 3f);
        image1.SetActive(false);
        yield return new WaitForSeconds(4);
        black.GetComponent<Image>().DOFade(0, 2f);
        yield return new WaitForSeconds(5);
        black.GetComponent<Image>().DOFade(1, 2f);
        yield return new WaitForSeconds(3);
        text.GetComponent<Text>().text = GameManager.gameManager.we[1];
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(4);
        text.GetComponent<Text>().DOFade(0, 3f);
        image2.SetActive(false);
        yield return new WaitForSeconds(4);
        black.GetComponent<Image>().DOFade(0, 2f);
    }*/
    IEnumerator End()
    {
        jingluo.GetComponent<Text>().DOFade(1, 2f);
        yield return new WaitForSeconds(4);
        jingluo.GetComponent<Text>().DOFade(0, 2f);
        yield return new WaitForSeconds(5);
        Audio.Play();
        GameObject.Find("Main Camera").GetComponent<AudioSource>().volume = 0.6f;
        foreach(string p in GameManager.gameManager.we)
        {
            text.GetComponent<Text>().text = p;
            text.GetComponent<Text>().DOFade(1, 3f);
            yield return new WaitForSeconds(5);
            text.GetComponent<Text>().DOFade(0, 3f);
            yield return new WaitForSeconds(6);
        }
        black.GetComponent<Image>().DOFade(0, 2f);
        yield return new WaitForSeconds(5);
        black.GetComponent<Image>().DOFade(1, 2f);
        yield return new WaitForSeconds(3);
        image1.SetActive(false);
        black.GetComponent<Image>().DOFade(0, 2f);
        yield return new WaitForSeconds(5);
        black.GetComponent<Image>().DOFade(1, 2f);
        yield return new WaitForSeconds(3);
        image2.SetActive(false);
        black.GetComponent<Image>().DOFade(0, 2f);
        yield return new WaitForSeconds(5);
        black.GetComponent<Image>().DOFade(1, 2f);
        yield return new WaitForSeconds(3);
        //word
        text.GetComponent<Text>().text = word1;
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(5);
        text.GetComponent<Text>().DOFade(0, 3f);
        yield return new WaitForSeconds(4);
        text.GetComponent<Text>().text = word2;
        text.GetComponent<Text>().fontSize = 12;
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(5);
        text.GetComponent<Text>().DOFade(0, 3f);
        yield return new WaitForSeconds(4);
        text.GetComponent<Text>().text = word3;
        text.GetComponent<Text>().fontSize = 20;
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(5);
        text.GetComponent<Text>().DOFade(0, 3f);
        yield return new WaitForSeconds(4);
        text.GetComponent<Text>().text = word4;
        text.GetComponent<Text>().fontSize = 30;
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(5);
        text.GetComponent<Text>().DOFade(0, 3f);
        yield return new WaitForSeconds(4);
        text.GetComponent<Text>().text = word5;
        text.GetComponent<Text>().DOFade(1, 3f);
        yield return new WaitForSeconds(5);
        text.GetComponent<Text>().DOFade(0, 3f);
        yield return new WaitForSeconds(4);
        Application.Quit();
    }
}
