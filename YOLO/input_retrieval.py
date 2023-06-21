import argparse
import os

def parseCommandLineArguments():
	ap = argparse.ArgumentParser()
	ap.add_argument("-i", "--input", required=True)
	ap.add_argument("-y", "--yolo", required=True)
	ap.add_argument("-o", "--output", required=False)
	ap.add_argument("-c", "--confidence", type=float, default=0.5)
	ap.add_argument("-t", "--threshold", type=float, default=0.3)
	ap.add_argument("-u", "--use-gpu", type=bool, default=False)
	ap.add_argument("-s", "--save-data", type=bool, default=False, required=False)

	args = vars(ap.parse_args())

	labelsPath = os.path.sep.join([args["yolo"], "coco.names"])
	LABELS = open(labelsPath).read().strip().split("\n")

	weightsPath = os.path.sep.join([args["yolo"], "yolov3.weights"])
	configPath = os.path.sep.join([args["yolo"], "yolov3.cfg"])
	
	inputVideoPath = args["input"]
	outputVideoPath = args["output"]
	confidence = args["confidence"]
	threshold = args["threshold"]
	USE_GPU = args["use_gpu"]
	SAVE_DATA = args["save_data"]

	return LABELS, weightsPath, configPath, inputVideoPath, outputVideoPath, confidence, threshold, USE_GPU, SAVE_DATA