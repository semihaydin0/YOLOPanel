import os
import subprocess

for fileName in os.listdir(r"C:\Users\PHOENIX\Desktop\Tez\app\inputVideos"):
	lastDotIndex = fileName.rfind(".")
	cmd = "python yolo_video.py --input inputVideos/trf2.mp4 --output outputVideos/" + \
		fileName[:lastDotIndex] + ".avi --yolo yolo-coco"
	subprocess.run(cmd, shell=True,cwd='Desktop\\Tez\\app')