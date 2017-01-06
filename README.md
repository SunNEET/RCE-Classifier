# RCE-Classifier

用來示範在二維input vector下，RCE神經網路概念的C#專案

想知道什麼是RCE以及二維限定的狀況可以參考這裡 : [Restricted Coulomb Energy (RCE) Classifier](http://neuron.eng.wayne.edu/tarek/MITbook/chap6/6_3.html) 

# Example
![aa](http://i.imgur.com/vAibT0a.png)
- 二維座標點相當於input vector {x1, x2}
- Wj1,Wj2 是 分類圈圈的圓心, lamda_j是半徑
- 該圈圈內皆視為同一種分類, 若不合, 會自動調整半徑大小
- 可以中途追加訓練資料

### 一些細節
- 最開始的Internal Node, 是將lamda_j的半徑初始化成畫面的一半
- 當 Oj - Dj == 1時, lamda_j 要減少的量, 直接設定為 Sj - 1
