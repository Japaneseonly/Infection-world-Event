using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Text型を扱うために導入
public class EncountManager : MonoBehaviour
{
    [SerializeField] Text ResultText = null;//エンカウント処理結果を表示させるTextオブジェクトとの連携のために導入
    int[] resultID = new int[20];//処理結果を表すID resultID[0]:スライムとのエンカウント　resultID[1]:ゴブリンとのエンカウント　resultID[2]:エンカウントなしを表すものとする
    float[] resultAR = new float[20];//各resultIDの出現率(resutAR[resultID]がresultIDが示す事象の出現確率を示す）    
    //エネミーとのエンカウント計算処理を行うメソッド
    public void EncountCulc()
    {
        int result;//エンカウント計算結果のresultIDを格納する作業用変数
        int count = 0;//作業用変数
        int[] encount = new int[100];//各確率に応じた数のresultIDを格納する変数(今回の場合は出現率は整数であるとして場合は配列の大きさを100とする)
        //変数の初期化処理///////////////////////////
        for (int i = 0; i < 20; i++)
        {
            resultID[i] = i;
        }
        resultAR[0] = 0.08f;//スライムとのエンカウント率を30%に設定
        resultAR[1] = 0.02f;//ゴブリンとのエンカウント率を20%に設定
        resultAR[2] = 0.03f;
        resultAR[3] = 0.07f;
        resultAR[4] = 0.06f;
        resultAR[5] = 0.07f;
        resultAR[6] = 0.03f;
        resultAR[7] = 0.02f;
        resultAR[8] = 0.08f;
        resultAR[9] = 0.09f;
        resultAR[10] = 0.01f;
        resultAR[11] = 0.06f;
        resultAR[12] = 0.04f;
        resultAR[13] = 0.03f;
        resultAR[14] = 0.07f;
        resultAR[15] = 0.02f;
        resultAR[16] = 0.08f;
        resultAR[17] = 0.05f;
        resultAR[18] = 0.05f;
        resultAR[19] = 0.04f;

        //魔物と遭遇しない確率を50%に設定
        //変数の初期化処理終了////////////////////////
        //encount配列の中身を0に初期化
        for (int i = 0; i < encount.Length; i++)
        {
            encount[i] = 0;
        }
        //resultIDの出現率に従ってresultIDを配列変数encount格納する処理
        for(int i = 0; i < resultID.Length; i++)
        {
            if (resultAR[i] != 0)
            {
                for (int j = 0; j < Mathf.Floor(resultAR[i] * 100); j++)//出現率がfloatなので100倍して整数にする。小数点以下の誤差対策として切り捨て処理(Mathf.Floor)を使用する
                {
                    encount[count] = resultID[i];
                    count++;
                }
            }
        }
        //ランダム関数を使用するので、先にランダムシードを時刻により初期化して、ランダム性を上げる
        Random.InitState(System.DateTime.Now.Millisecond);
        //ランダムインデックスを計算
        int randomIndex = Random.Range(0, encount.Length);
        //確率に応じたにエンカウント計算結果を変数result
        result= encount[randomIndex];
        //計算結果に応じてテキストオブジェクトの表示を変更する処理
        if (result == resultID[0])
        {
            ResultText.text = "変異ウイルスの出現";
        }
        else if (result == resultID[1])
        {
            ResultText.text = "暴動";
        }
        else if (result == resultID[2])
        {
            ResultText.text = "対策本部の火災";
        }
        else if (result == resultID[3])
        {
            ResultText.text = "国民からの賞賛";
        }
        else if (result == resultID[4])
        {
            ResultText.text = "助成金の着服";
        }
        else if (result == resultID[5])
        {
            ResultText.text = "Youtuberの感染対策情報発信";
        }
        else if (result == resultID[6])
        {
            ResultText.text = "ワクチンの大量廃棄";
        }
        else if (result == resultID[7])
        {
            ResultText.text = "政治家の集団飲み会";
        }
        else if (result == resultID[8])
        {
            ResultText.text = "誤情報の発信";
        }
        else if (result == resultID[9])
        {
            ResultText.text = "研究所への寄付";
        }
        else if (result == resultID[10])
        {
            ResultText.text = "対策本部の火災";
        }
        else if (result == resultID[11])
        {
            ResultText.text = "地震";
        }
        else if (result == resultID[12])
        {
            ResultText.text = "台風";
        }
        else if (result == resultID[13])
        {
            ResultText.text = "大洪水";
        }
        else if (result == resultID[14])
        {
            ResultText.text = "マスク反対デモ";
        }
        else if (result == resultID[15])
        {
            ResultText.text = "ワクチン反対デモ";
        }
        else if (result == resultID[16])
        {
            ResultText.text = "映画「私感染しないので」が大ヒット";
        }
        else if (result == resultID[17])
        {
            ResultText.text = "医学部生出陣";
        }
        else if (result == resultID[18])
        {
            ResultText.text = "１０万円配布";
        } 
        else if (result == resultID[19])
        {
            ResultText.text = "スマホ版「I.W」が世界的大ヒット";
        }
        else
        {
            ResultText.text = "大谷翔平の活躍";
        }
    }
}
