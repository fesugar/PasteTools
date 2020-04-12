# PasteTools
 软件用来对一些需要大量输入相同内容的文本进行预设好数据后然后快捷粘贴即可，比使用查找文本数据，然后在使用快捷键 Ctrl + C 、 Ctrl + V 方便的多。

# 设计原理
采用模拟快捷键的方式快速粘贴需要回复的内容。（注意粘贴时确保光标焦点位于回复编辑框里）
注意：软件使用.NET 编写，因此运行此软件需要Microsoft NET Framework 3.5 框架的支持，Windows 7 系统已经默认安装此框架
如果运行中提示 “0xc0000135” 相关错误请先安装.NET 3.5
NET Framework 3.5 微软官网下载地址：
http://www.microsoft.com/zh-cn/download/details.aspx?id=21

# 最低 dotnet 版本需求 2.0

# 使用方法
1、粘贴数据
启动软件，光标至于需要进行输入文本的编辑框内，点击需要粘贴的数据按钮名称，数据将会粘贴到文本框中。

2、修改数据
进入设置面板，点击粘贴数据勾选框将展开修改界面，点击需要修改或者添加的按钮，然后输入对应数据，点击添加，如果状态显示 成功 则数据成功添加，然后在设置面板中勾选上数据增改的勾选框，将返回粘贴数据状态。

3、删除数据
进入设置面板，点击粘贴数据勾选框将展开修改界面，点击需要修改或者添加的按钮，然后点击删除按钮，如果状态显示 成功（英文） 则数据成功删除，然后在设置面板中勾选上数据增改的勾选框，将返回粘贴数据状态。

4、自动回复的快捷键设置
自动回复快捷键有两个快捷键， Enter  Ctrl+Enter  进入设置面板，进行切换。

5、自定义界面颜色设置
进入设置面板，在杂项归纳框中，找到主界面颜色设置和设置面板颜色设置，可以打开颜色面板选择自定义颜色。

6、软件更新
请转到安装目录下运行 升级程序(PasteToolsUp) 检测更新新版本。

7、模式选择
模式选择用来增加数据，如果当前选择的配置文件60个数据都已经满了，可以进行增加。


![粘贴工具](https://github.com/fesugar/PasteTools/raw/master/screen.JPG)