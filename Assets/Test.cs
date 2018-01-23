using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {        
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    // MP

    // 攻撃用の関数
    public void Attack() { 
        Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public  void Defence(int damage) { 
        Debug.Log( damage+"のダメージを受けた" );
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic(int magicCost)
    {
        string message = "MPが足りないため魔法が使えない。";

        if(mp >= magicCost){
            mp -= magicCost;
            message = "魔法攻撃をした。残りMPは" + mp;
        }

        Debug.Log (message);
    }
}

public class Test : MonoBehaviour {

    private int[] array = new int[5];

    void Start () {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss ();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);


        //課題：配列を宣言して出力しましょう
        Debug.Log("課題：配列を宣言して出力しましょう");
        initArray(255);
        dispArray ();
        dispArrayReverseOrder();

        //発展課題：ossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
        Debug.Log("発展課題：ossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう");
        // 魔法攻撃用の関数を呼び出す
        lastboss.Magic(5);

        for(int i=0 ; i<20 ; i++){
            lastboss.Magic (5);
        }
    }

    void initArray(int maxValue){
        
        Debug.Log( "配列arrayを初期化します");

        for(int i=0 ; i<this.array.Length ; i++)
        {
            int temp = (int)Random.Range (0, maxValue);
            array [i] = temp;
        }
        Debug.Log( "配列arrayを初期化しました");
    }

    void dispArray()
    {
        Debug.Log( "配列arrayを順番に表示します");
        Debug.Log( "-----開始-----");
        Debug.Log( "array[0] = " + array[0]);
        Debug.Log( "array[1] = " + array[1]);
        Debug.Log( "array[2] = " + array[2]);
        Debug.Log( "array[3] = " + array[3]);
        Debug.Log( "array[4] = " + array[4]);
        Debug.Log( "-----終了-----");
    }

    void dispArrayReverseOrder()
    {
        Debug.Log( "配列arrayを逆順に表示します");
        Debug.Log( "-----開始-----");

        for(int i=array.Length-1 ; i>=0 ; i--)
        {
            Debug.Log( "array["+ i +"] = " + array[i]);
        }

        Debug.Log( "-----終了-----");
    }

    // Update is called once per frame
    void Update () {

    }
}
