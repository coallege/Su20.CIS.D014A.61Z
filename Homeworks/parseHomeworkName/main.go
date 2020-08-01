package main

import (
	"github.com/lxn/walk"
	. "github.com/lxn/walk/declarative"
)

var txtInput, txtOutput *walk.TextEdit

func main() {
	MainWindow{
		Title: "Parse Homework Name",
		Size:  Size{500, 200},
		Font: Font{
			Family:    "Consolas",
			PointSize: 12,
		},
		Layout: HBox{}, // bair
		Children: []Widget{
			HSplitter{
				Children: []Widget{
					TextEdit{
						AssignTo: &txtInput,
						OnKeyUp: func(key walk.Key) {
							nicename, err := parse(txtInput.Text())
							if err == nil {
								txtOutput.SetText(nicename)
							}
						},
					},
					TextEdit{AssignTo: &txtOutput, ReadOnly: true},
				},
			},
		},
	}.Run()
}
