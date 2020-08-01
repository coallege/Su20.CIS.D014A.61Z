run: parseHomeworkName.exe
	./$<

parseHomeworkName.exe: main.go parsehomeworkname.go Manifest.syso
	go build -ldflags="-H windowsgui"

release: Manifest.syso
	go build -ldflags="-s -H windowsgui"

Manifest.syso: Manifest.xml
	rsrc -manifest $< -o $@

.PHONY: run build release
