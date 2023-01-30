# UnityTestSaveSystem

セーブ機能を作る際に何を使えばいいか悩んだため、たくさん作って試す。
_______________________________________________________________________________________________________________________________
前提: ステージクリア時などにセーブが呼ばれ、現在のステージ番号を保存する。Startでデータを呼び、データの回数分配列内のオブジェクトを表示する。
<br><br>
`ScriptableObject` ScriptableObject内にあるintを呼びfor文でintの回数分オブジェクトを表示する。  

`JsonUtility`　Save,Loadの仕組みは基本的に同じで、jsonファイルに書き込むため、ファイルの確認を行っている。　　

`ZeroFormatter`　作成途中　仕組み的に、今回作っているセーブシステムには合わない気がする。

`MessagePack`　作成予定  

[ZeroFormatter(GitHub)](https://github.com/neuecc/ZeroFormatter)
