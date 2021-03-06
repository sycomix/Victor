import sys
import io
import os
import shutil
from io import TextIOWrapper, BytesIO
from contextlib import redirect_stdout
import json

from snips_nlu.cli import training
from snips_nlu.cli import generate_dataset
from snips_nlu import SnipsNLUEngine
from snips_nlu.default_configs import CONFIG_EN

engine = SnipsNLUEngine(config=CONFIG_EN)

def train_model(_input, name, sub=""):
    input = os.path.join("..", "Victor.NLU.Snips", "Datasets", sub, _input)
    output = input.replace(".yaml", ".json")
    with TextIOWrapper(io.FileIO(output, "wb"), sys.stdout.encoding) as buf, redirect_stdout(buf):
        generate_dataset.generate_dataset("en", input)
        buf.flush()
        buf.close()
    
    engine_path = os.path.join("..", "Victor.NLU.Snips", "Engines", sub, name)
    if os.path.isdir(engine_path): 
        shutil.rmtree(engine_path)
        
    with io.open(output) as f:
        dataset = json.load(f)
    engine.fit(dataset)
    engine.persist(engine_path) #os.path.join(os.path.dirname(input), "..", "Engines", sub, name))

    