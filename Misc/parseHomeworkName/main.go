package main

import (
	"github.com/lxn/walk"
	. "github.com/lxn/walk/declarative"
)

var txtInput, txtOutput *walk.TextEdit

func main() {
	MainWindow{
		Title: "Parse Homework Name",
		// the VBox will make the minimum size = to the TextLabel
		// so it's okay to have the Width be 1
		Size: Size{Width: 1, Height: 300},
		Font: Font{
			Family:    "Consolas",
			PointSize: 12,
		},
		Layout: VBox{}, // bair
		Children: []Widget{
			TextLabel{
				Text: "Enter the homework or assignment name into the top Text Area",
			},
			VSplitter{
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
