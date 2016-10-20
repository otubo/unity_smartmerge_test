O dia na vida de um programador que usa git e Sourcetree
===================

Vou descrever as operações básicas para o dia-a-dia comum de um usuário de git e Sourcetree no desenvolvimento de software. A sequência padrão de ações é:

 1. `Clone` (fresh start) / `Pull` (update)
- Use sempre `Clone` para iniciar um repositório existente.
- Ou `Pull` para atualizar mudanças no projeto por terceiros. Este procedimento nunca haverá conflitos, já que as pessoas sempre trabalharão em suas próprias `branches`. Este procedimento vai sempre atualizar o `master` e eventuais novas `branches` criadas e publicadas por outras pessoas do time.
 2. `Branch` bugXX
- Sempre que começar uma feature ou bug novo crie um novo `branch`
![Criando um novo branch](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/branch.png)
 3. trabalho; `Commit` (repete n vezes)
- `commits` são gratuitos. Use quantas vezes achar que possa ajudar no entendimento da implementação do seu trabalho
![Primeiro commit](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/primeiro.png)
![Modificações fora do Staging](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/unstaged.png)
![Modificações no Staging](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/staged.png)
![Primeiro commit feito](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/primeiro_commit_overall.png)
 4. `Rebase` master (caso necessário)
- Atualize a sua `branch` com informações do `master` quando houver
![Atualizando a sua branch](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/rebase2.png)
- Neste ponto do trabalho você pode dar `push` nos seus `commits` e publicar seu `branch` para revisão
![Publicando alterações pro servidor](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/push.png)
 5. `Rebase` branch bugXX
- Alguém (o próprio desenvolvedor, ou outro membro do time) pode revisar a `branch` e fazer `rebase`pdps alterações propostas no `master`. Isso pode ser feito usando o `Rebase` do Sourcetree ou proposto como um `Pull Request` pelo Github.
![Atualizando o Master](https://raw.githubusercontent.com/otubo/unity_smartmerge_test/master/pictures/rebase1.png)
