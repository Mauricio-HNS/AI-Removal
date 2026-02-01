import random

def classify(file_name):
    # Simula classificação de ameaça
    types = ["Bot", "Spyware", "Adware", "Unknown"]
    return random.choice(types)

if __name__ == "__main__":
    import sys
    name = sys.argv[1] if len(sys.argv) > 1 else "UnknownFile.exe"
    result = classify(name)
    print(f"Threat type: {result}")
