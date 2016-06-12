function displayimg(imgpass){
	//各イメージパスを配列に設定
	img[1]=new Image();
	img[1].src="img/icon1.jpg";
	img[2]=new Image();
	img[2].src="img/icon2.jpg";
	img[3]=new Image();
	img[3].src="img/icon3.jpg";

	//押したボタンに紐づく画像を表示
	document.getElementById("img").src = img[imgpass].src;
}