.PHONY: debug
debug:
	msbuild "Ricardo.Salesforce.DMP.Android/Ricardo.Salesforce.DMP.Android.sln" /p:Configuration=Debug
.PHONY: release
release:
	 msbuild "Ricardo.Salesforce.DMP.Android/Ricardo.Salesforce.DMP.Android.sln" /p:Configuration=Release
.PHONY: pack
pack:
	make release
	nuget pack dmp.nuspec
