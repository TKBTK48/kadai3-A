/*
 * PTra12_06.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;
using Question12_Extends.common;

public class PTra12_06
{
    /*
  	 * TODO commonにHeroクラスを継承した、SuperHeroクラスを作成してください
  	 * 	●HP, POWER, ENDURANCEはHeroと同じでそれぞれ、（25, 10, 7）
  	 *
  	 * フィールド
  	 * 		item	:	Item
  	 * メソッド
  	 * 		Attackメソッドをオーバーライドし、
  	 * 		powerフィールドの値に加えて、itemフィールドのadditionalDamage分を加算した値を返す
  	 *
  	 * 		itemフィールドのアクセサ
  	 */
    public static void Main(string[] args)
    {
        // TODO SuperHeroインスタンスを作成し、名前に"勇者(装備あり)"を設定してください
        var superherosample = new SuperHero();
        superherosample.SetName("勇者(装備あり)");

        // TODO Itemクラスのインスタンスを作成し、("こんぼう", 5）をコンストラクタの引数にしてください
        var konbou = new Item("こんぼう", 5);

        // TODO SuperHeroインスンタンスのitemフィールドに作成したitemインスタンスをセットしてください
        superherosample.item = konbou;

        // TODO SuperHeroインスンタンスのAttackメソッドを呼び出して、戻り値を出力してください
        // ※ 15と出力されれば正解
        Console.WriteLine(superherosample.Attack());

    }
}
