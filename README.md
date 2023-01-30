# UnityTestSaveSystem

セーブ機能を使う際に何を使えばいいか悩んだため、たくさん作って試す。
_______________________________________________________________________________________________________________________________
前提: ステージクリア時などにセーブが呼ばれ、現在のステージ番号を保存する。Startでデータを呼び、データの回数分配列内のオブジェクトを表示する。
<br><br>
`ScriptableObject`
[ScriptableObject](https://github.com/YutaKonoma/UnityTestSaveSystem/tree/master/Assets/Scripts/ScriptableObject)
ScriptableObject内にあるintを呼びfor文でintの回数分オブジェクトを表示する。  

`JsonUtility`　
[JsonUtility](https://github.com/YutaKonoma/UnityTestSaveSystem/tree/master/Assets/Scripts/JsonUtility)
Save,Loadの仕組みは基本的に同じで、jsonファイルに書き込むため、ファイルの確認を行っている。　　

`ZeroFormatter`
[ZeroFormatter](https://github.com/YutaKonoma/UnityTestSaveSystem/tree/master/Assets/Scripts/ZeroFormatter)
作成途中　仕組み的に、今回作っているセーブシステムには合わない気がする。

`MessagePack`　作成予定  

[ZeroFormatter(GitHub)](https://github.com/neuecc/ZeroFormatter)  Unity 2021.3.8f1

