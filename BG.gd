extends ParallaxBackground


var scrolling_speed = 100

func _process(delta):
	scroll_offset.x -= scrolling_speed * delta


func _on_texture_button_pressed():
	pass # Replace with function body.
