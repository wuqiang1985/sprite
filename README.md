sprite
======
A Windows Form application based by C#, which helps front-end engineer and designer to combine multi-image into one,  the style files will be generated at the same time.

###Why do we should use sprite technology?###
When browser visit a web page which contains plenty of images, it has to raise a request to web server for each image. While these requests will coast so much time, it's waste. Spirte is to combine these images into one and use css background-position to locate the image. After this, when people visit the page, it will be on the fly.

###Why do I write the sprite tool?###

In the old flow:

1. designer will cut the images;

2. combine them via PhotoShop manually;

3. front-end engineer write the background-postion to locate the image;

WTF, the step2,3 is so boring...

If you use the sprite tool, the new flow is:

1. designer will cut the images;

2. anyone just click the button "Go", the sprite image and css will be done automaticlly

###How to use the sprite tool?###

Just named the images by rules and indicate the folder which the "png" images in. Click button "Go"

###Reference###

Here are the rules of image naming(left: image file name without extension, right: class name):

wechat => .wechat

wechat_hover => .wechat:hover

wechat-hover => .wechat:hover

wechat_ibg_hover => .wechat_ibg:hover

wechat-ibg-hover => .wechat-ibg:hover

wechat.ibg => .wechat .ibg

wechat.ibg.wechat_focus => .wechat .ibg .wechat:focus

wechat.ibg.wechat_none => .wechat .ibg . wechat_none

wechat_hover.wechat_none => .wechat:hover .wechat_none

wechat-hover.wechat-none => .wechat:hover .wechat-none

###Note###
The sprite tool will process the file name end with as "-hover" or "_hover"  to css pseudo class ":hover".

The others pseudo class (":link, :visited, :hover, :active, :focus, :before, :after, :lang") will be processed the same way too.

###Environment###
windows .net framework 2.0 or later

###Other###
Someone maybe will say: "why not use Sass and compass, it has the sprite feature too".

Well Sass is awesome, but you need to study it. I just provide another option for you.

