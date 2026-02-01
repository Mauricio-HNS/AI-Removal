import random

def analyze_behavior(file_path):
    # Simula nível de ameaça com base no nome do arquivo
    levels = ["Low", "Medium", "High", "Critical"]
    threat_level = random.choice(levels)
    return {"file": file_path, "level": threat_level}

if __name__ == "__main__":
    import sys
    path = sys.argv[1] if len(sys.argv) > 1 else "UnknownFile.exe"
    result = analyze_behavior(path)
    print(result)
