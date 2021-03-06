using System;
using System.Collections.Generic;
using System.Collections;

class Model
{
    protected ClassCreater _classCreater;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Model()
    {
        _classCreater = new ClassCreater();
    }

    internal ClassCreater ClassCreater
    {
        get => default;
        set
        {
        }
    }

    /// <summary>
    /// クラスの追加(インスタンス化)
    /// </summary>
    /// <param name="msg"></param>
    public void CreateNewClass(string className)
    {
        _classCreater.CreateNewClass(className);
    }

    /// <summary>
    /// クラスの決定通知
    /// </summary>
    public void FinishedCreateClass()
    {
        _classCreater.FinishedCreateClass();
    }


    /// <summary>
    /// ジェネリックで各Enumの文字列を取得する
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected string[] GetSelection<T>()
    {
        string[] choices = new string[Enum.GetNames(typeof(T)).Length];
        foreach (int Value in Enum.GetValues(typeof(T)))
        {
            string name = Enum.GetName(typeof(T), Value);
            choices[Value-1] = name;
        }
        return choices;
    }



    /// <summary>
    /// 作成中のクラスを取得する
    /// </summary>
    /// <returns></returns>
    public Class GetMakingClass()
    {
        return _classCreater.GetMakingClass();
    }

    /// <summary>
    /// クラスを取得する
    /// </summary>
    /// <returns></returns>
    public Class GetClass()
    {
        return _classCreater.GetClass();
    }


    /// <summary>
    /// 「クラス図を作成をします。(Escキーで終了)」を返す
    /// </summary>
    /// <returns></returns>
    public string GetFirstContext()
    {
       return  "クラス図を作成をします。(入力なしで終了)\n";
    }

    /// <summary>
    /// フィールドとメソッドの選択肢を返す
    /// </summary>
    /// <returns></returns>
    public string[] GetFieldAndMethodSelection()
    {
        string[] choices = {"フィールド", "メソッド"};
        return choices;
    }

    /// <summary>
    /// 「描画したいクラス名を入力してください。」を返す
    /// </summary>
    /// <returns></returns>
    public string GetClassNameContext()
    {
        return "描画したいクラス名を入力してください。\n";
    }

    /// <summary>
    /// 「アクセス修飾子を入力してください。」を返す
    /// </summary>
    /// <returns></returns>
    public string GetInputAccessor()
    {
        return "アクセス修飾子を入力してください。\n";
    }

    /// <summary>
    /// 「型名を選択してください。」を返す
    /// </summary>
    /// <returns></returns>
    public string GetInputType()
    {
        return "型名を選択してください。\n";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public FieldModel CreateFieldModel()
    {
        return new FieldModel();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public MethodModel CreateMethodModel()
    {
        return new MethodModel(); 

    }

    /// <summary>
    /// 決定したフィールドを追加する
    /// </summary>
    /// <param name="accessType"></param>
    /// <param name="dataType"></param>
    /// <param name="fieldName"></param>
    public void SetFieldToClass(Field field)
    {
        _classCreater.SetFieldToClass(field);
    }

    /// <summary>
    /// クラスにメソッド追加する
    /// </summary>
    /// <param name="accessType"></param>
    /// <param name="dataType"></param>
    /// <param name="methodName"></param>
    /// <param name="methodArgumentList"></param>
    public void SetMethodToClass(Method method)
    {
        _classCreater.SetMethodToClass(method);
    }


}

