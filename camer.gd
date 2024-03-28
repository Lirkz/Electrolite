extends Area2D

@onready var PhantomCamera2D1 = get_node("../../PhantomCamera2D1")
@onready var PhantomCamera2D2 = get_node("../../PhantomCamera2D2")


func _on_collision_shape_2d_child_entered_tree(node):
	PhantomCamera2D2.set_priority(2)
	PhantomCamera2D1.set_priority(1)
	
	
func _on_collision_shape_2d_child_exiting_tree(node):
	PhantomCamera2D1.set_priority(2)
	PhantomCamera2D2.set_priority(1)
