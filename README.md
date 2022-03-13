# 修改者的话
此版本有一定修改，若出现 bug 请提交 issue 。

# 源地址
[GitHub - jaquadro/NBTExplorer](https://github.com/jaquadro/NBTExplorer)
他好像上次更新是 3 年前...

# NBTExplorer

NBTExplorer 是一个开源 NBT 编辑器，适用于所有常见的 NBT 数据源。 它主要用于编辑[Minecraft](http://www.minecraft.net) 游戏数据。 

## 支持的格式

NBTExplorer 支持读写以下格式：

* 标准 NBT 文件（例如 level.dat） 
* 原理图文件
* 未压缩的 NBT 文件（例如 idcounts.dat）
* Minecraft 区域文件 (*.mcr) 
* Minecraft anvil 文件 (*.mca) 
* 立方块区域文件（r2\*.mcr、r2\*.mca） 

## 系统要求

### Windows

Windows XP or later, .NET Framework 2.0 or later.

由于使用 VS 2019 编译可能不适配旧版本。Windows 10适配。

### Linux

NBTExplorer 与最新的 Mono 运行时兼容，至少 2.6 或更高版本。

至少，您的系统需要 `mono-core` 和 `mono-winforms` 包，或任何等效的包集。 

### Mac

具有本机 UI 的单独 Mac 版本可用。 所有 Mono 依赖项都包含在应用程序包中。 支持的最低操作系统是 OSX 10.8 Mountain Lion，但它可以在早于 Snow Leopard 的版本上运行。 

如果 Mac 版本无法使用，Windows 版本的 NBTExplorer 仍然可以使用。 您将需要安装 Mono 运行时，然后从命令行使用 Mono 运行 NBTExplorer。 