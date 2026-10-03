var resource = EResource.LoadResource();
Console.WriteLine($"Embeded resource : {resource}");

var binaryResource = EResource.LoadBinaryResource();
if (binaryResource != null) {
  Console.WriteLine($"Embeded binary resource size : {binaryResource.Length} bytes");
} else {
  Console.WriteLine("バイナリリソース取得は失敗");
}