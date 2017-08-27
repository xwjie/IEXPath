# IEXPath
给公司测试同事做的一个IE下获取对象的XPath工具，支持32和64位

[点击下载最新版本](https://github.com/xwjie/IEXPath/blob/master/release/IEXPath.rar?raw=true)

# 当前最新版本
1.0，发布时间：2017.08.27

# 特性
* 支持 IE 32,64位
* 理论上支持所有IE版本
* 支持用 class，name 生成XPath

主要用于自动化测试中IE下获取元素的XPath，经过测试，结果和chrome生成的一样。工具也可以用于查看密码框里面自动保存的密码。

由于本人不负责自动化测试，开发的工具不一定满足测试人员的功能要求和符合大家的使用习惯，大家有什么建议或者bug请提 issues，我看到后会逐步实现。

# 使用方法
拖动左下角的图标到IE查看即可。

抓取元素的时候默认已经复制了第一个xpath。直接黏贴即可。

双击文本框即可复制内容，XPath选中后双击即可复制。

也可以【按F8】获取光标当前位置元素信息。用于一些失去焦点就消失的弹出层的信息获取。

> 注意：要保证IE右下角的缩放是100%，否则元素获取不准确。

![](/doc/1.png) 
![](/doc/iexpath.gif) 