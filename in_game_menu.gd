extends Node2D
var is_visible = false

func _ready():
	self.visible = is_visible
	
func _process(delta):
	if Input.is_action_just_pressed("ui_cancel"):
		is_visible = not is_visible
		self.visible = is_visible


func _on_texture_button_pressed():
	get_tree().change_scene_to_file("res://lvl_1_sub_area.tscn")
