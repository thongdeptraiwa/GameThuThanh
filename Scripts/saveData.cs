using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Data
{
    public int soMan;
    public int soSaoMan1;
    public int soSaoMan2;
    public int tongSao;
    public int cung3_1;
    public int cung3_2;
    public int phao3_1;
    public int phao3_2;
    //public bool nhac;
    //public bool tieng;

    //seter
    public void SetSoMan(int man)
    {
        this.soMan = man;
    }

    public void SetSoSaoMan1(int sao)
    {
        this.soSaoMan1 = sao;
    }

    public void SetSoSaoMan2(int sao)
    {
        this.soSaoMan2 = sao;
    }
    //shop
    public void SetTongSao(int sao)
    {
        this.tongSao = sao;
    }
    public void SetCung3_1(int x)
    {
        this.cung3_1 = x;
    }
    public void SetCung3_2(int x)
    {
        this.cung3_2 = x;
    }
    public void SetPhao3_1(int x)
    {
        this.phao3_1 = x;
    }
    public void SetPhao3_2(int x)
    {
        this.phao3_2 = x;
    }
    //public void SetNhac(bool x)
    //{
    //    this.nhac = x;
    //}
    //public void SetTieng(bool x)
    //{
    //    this.tieng = x;
    //}
}

public static class saveData 
{
    public const string All_data = "all_data";
    public static Data data ;
    
    public static void Save(int man,int sao)
    {
        
        
        if(man == 1)
        {
            if (data.soSaoMan1 <= sao)
            {
                data.tongSao = data.tongSao +(sao - data.soSaoMan1);
                data.soSaoMan1 = sao;
                SaveData();
            }
        }
        if (man == 2)
        {
            if (data.soSaoMan2 <= sao)
            {
                data.tongSao = data.tongSao + (sao - data.soSaoMan2);
                data.soSaoMan2 = sao;
                SaveData();
            }
        }
        if (data.soMan == man)
        {
            data.soMan++;
            SaveData();
        }

    }

    //public static void LoadData()
    //{
    //    string file = "data.json";
    //    string filePath = Path.Combine(Application.persistentDataPath, file);
    //    if (!File.Exists(filePath))
    //    {
    //        File.WriteAllText(filePath, "");
    //    }

    //    //if (data == null)
    //    //{
    //    //    data = new Data
    //    //    {
    //    //        soMan = 1,
    //    //        soSaoMan1 = 0,
    //    //        soSaoMan2 = 0,
    //    //    };
    //    //    SaveData();
    //    //}
    //    data = JsonUtility.FromJson<Data>(File.ReadAllText(filePath));
    //    Debug.Log("Load done!");
    //}

    //public static void SaveData()
    //{
    //    string file = "data.json";
    //    string filePath = Path.Combine(Application.persistentDataPath, file);
    //    string json = JsonUtility.ToJson(data,true);

    //    File.WriteAllText(filePath, json);
    //    Debug.Log("File path : " + filePath);
    //}



    public static void LoadData()
    {
        data = JsonUtility.FromJson<Data>(PlayerPrefs.GetString(All_data));

        //if(data == null)
        //{
        //    data = new Data
        //    {
        //        soMan = 1,
        //        soSaoMan1 = 0,
        //        soSaoMan2 = 0,
        //        //nhac = true,
        //        //tieng = true,
        //    };
        //    SaveData();
        //}
    }
    public static bool checkData()//false la data rong
    {
        LoadData();
        if(data == null || (data.soMan == 1 && data.soSaoMan1 == 0))
        {
            return false;
        }
        return true;
    } 
    public static void ResetData()
    {
        data = new Data
        {
            soMan = 1,
            soSaoMan1 = 0,
            soSaoMan2 = 0,
            tongSao = 0,
            cung3_1 = 0,
            cung3_2 = 0,
            phao3_1 = 0,
            phao3_2 = 0,
            //nhac = true,
            //tieng = true,
        };
        SaveData();
    }



    public static void SaveData()
    {
        var json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(All_data,json);
    }

    //get
    public static int GetSoMan()
    {
        return data.soMan;
    }
    public static int GetSoSaoMan1()
    {
        return data.soSaoMan1;
    }
    public static int GetSoSaoMan2()
    {
        return data.soSaoMan2;
    }
    //get shop
    public static int GetTongSao()
    {
        return data.tongSao;
    }
    public static int GetCung3_1()
    {
        return data.cung3_1;
    }
    public static int GetCung3_2()
    {
        return data.cung3_2;
    }
    public static int GetPhao3_1()
    {
        return data.phao3_1;
    }
    public static int GetPhao3_2()
    {
        return data.phao3_2;
    }
    //public static bool GetNhac()
    //{
    //    return data.nhac;
    //}
    //public static bool GetTieng()
    //{
    //    return data.tieng;
    //}
    //set
    public static void SetSoMan(int man)
    {
        data.SetSoMan(man);
        SaveData();
    }
    public static void SetSoSaoMan1(int sao)
    {
        data.SetSoSaoMan1(sao);
        SaveData();
    }
    public static void SetSoSaoMan2(int sao)
    {
        data.SetSoSaoMan2(sao);
        SaveData();
    }
    //set shop
    public static void SetTongsao(int sao)
    {
        data.SetTongSao(sao);
        SaveData();
    }
    public static void SetCung3_1(int x)
    {
        data.SetCung3_1(x);
        SaveData();
    }
    public static void SetCung3_2(int x)
    {
        data.SetCung3_2(x);
        SaveData();
    }
    public static void SetPhao3_1(int x)
    {
        data.SetPhao3_1(x);
        SaveData();
    }
    public static void SetPhao3_2(int x)
    {
        data.SetPhao3_2(x);
        SaveData();
    }
    //public static void SetNhac(bool x)
    //{
    //    data.SetNhac(x);
    //    SaveData();
    //}
    //public static void SetTieng(bool x)
    //{
    //    data.SetTieng(x);
    //    SaveData();
    //}
}
