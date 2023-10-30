using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChatSystem : MonoBehaviour
{
    public Image character1Image;
    public Image character2Image;
    public Text nameText;
    public Text dialogueText;
    public Image background; // 배경 이미지를 표시할 UI Image

    private string[] dialogueLines;
    private int currentLine = 0;

    private float maxAlpha = 1.0f; // 최대 투명도
    private float minAlpha = 0.5f; // 최소 투명도

    public Sprite[] backgrounds;

    void Start()
    {
        dialogueLines = new string[]
        {
            "라라: 안녕, 에버랜드 친구들! 난 에버토피아에 살고 있는 라라야",
            "레나: 나도 에버토피아에 살고 있고, 이름은 레나야! 만나서 반가워",
            "라라: 우리를 도와준다고 들었어! 그럼 간단하게 우리의 상황을 말해줄게",
            "레나: 에버랜드와 에버토피아는 서로 공존하며 살아가고 있어!",
            "라라: 에버랜드에서 만들어진 사람들의 즐거움이 행복 에너지가 에버토피아의 글로벌 페어에 있는 매직트리로 모여 에버토피아에 사는 주민의 힘이 되고, 악당으로부터 보호해줘",
            "레나: 행복에너지는 정말 대단해!! 그런데 저번주에 나타난 나쁜 녀석들이 매직 트리에 있는 행복의 에메랄드를 깨버렸어.",
            "라라: 우리는 이 에메랄드를 복원하기 위해 온 힘을 쏟았지만, 에버랜드의 엄청난 행복 에너지가 필요해",
            "레나: 에버토피아를 위해 놀이동산을 운영해서 에버랜드 사람들의 즐거움을 모아줄 수 있니??",
            "라라: 부탁할게!!!"
        };

        ShowNextLine();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowNextLine();
        }
    }
    void ShowNextLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            string line = dialogueLines[currentLine];
            string[] parts = line.Split(':');

            if (parts.Length == 2)
            {
                string characterName = parts[0];
                string dialogue = parts[1];

                nameText.text = characterName; // 등장인물 이름을 표시
                dialogueText.text = dialogue;

                if (characterName == "라라")
                {
                    SetCharacterAlpha(character1Image, maxAlpha);
                    SetCharacterAlpha(character2Image, minAlpha);
                }
                else if (characterName == "레나")
                {
                    SetCharacterAlpha(character1Image, minAlpha);
                    SetCharacterAlpha(character2Image, maxAlpha);
                }

                if (currentLine < backgrounds.Length)
                {
                    background.sprite = backgrounds[currentLine];
                }
            }

            currentLine++;
        }
        else
        {
            SceneManager.LoadScene("Main");
        }

        void SetCharacterAlpha(Image characterImage, float alpha)
        {
            Color color = characterImage.color;
            color.a = alpha;
            characterImage.color = color;
        }
    }
}