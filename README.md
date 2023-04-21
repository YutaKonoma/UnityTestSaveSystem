# UnityTestSaveSystem

セーブ機能を使う際に何を使えばいいか悩んだため、たくさん作って試した。
_______________________________________________________________________________________________________________________________
前提: ステージクリア時などにセーブが呼ばれ、現在のステージ番号intで保存する。ゲームスタート時やセレクト画面に戻ってきた際にLoadを呼び、for文でデータの回数分配列内のオブジェクトを表示する。
<br><br>

`JsonUtility`　
[JsonUtility](https://github.com/YutaKonoma/UnityTestSaveSystem/tree/master/Assets/Scripts/JsonUtility)
Load jsonファイル内のint値だけfor文でボタンを開放している。save ファイルの有無を確認してない場合には作成してから保存するようにしている。　

`ZeroFormatter`
[ZeroFormatter](https://github.com/YutaKonoma/UnityTestSaveSystem/tree/master/Assets/Scripts/ZeroFormatter)
作成途中　仕組み的に、今回作っているセーブシステムには合わない気がする。

`MessagePack`　作成予定  

`PlayerPrefs` 

[ZeroFormatter(GitHub)](https://github.com/neuecc/ZeroFormatter)  Unity 2021.3.8f1

