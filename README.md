# CG_Final
 
## Build

Here is the final build on a goodle drive.

https://drive.google.com/file/d/1CQjtWZ_uBCFLPGGLqWVz0-MpIc16VBDR/view?usp=share_link
 
These are the textures I used online and their sources.

https://orig00.deviantart.net/a7c0/f/2015/013/d/c/lava_texture_by_beijing54-d8dqux9.jpg
![Lava](https://user-images.githubusercontent.com/116387786/233704189-dc1be0f9-e001-4cf2-9948-8c9419fdb31d.jpg)

https://www.trsearch.org/images/items/Sabatu/Sabatu_SimpleLavaTexture512x512Pixels.png
![Lava2](https://user-images.githubusercontent.com/116387786/233704233-7729ecea-0b45-434b-b50c-c90b795a1224.png)

https://steamusercontent-a.akamaihd.net/ugc/2429005285070992894/65B32CF6DE5AC0F07A4AEC3539FF5BB7E3B093B0/
![BG](https://user-images.githubusercontent.com/116387786/233704273-dacdf3b3-f796-47ea-bb53-801511b5811e.png)


I was tasked with doing the even number scene.

## Lava

I started off with the lava scrolling texture.

The shader I took from the lecture was the basic scrolling texture shader, I then decided to combine it with the water shader to make it look like real lava/fire as well as to give it some depth.

![image](https://user-images.githubusercontent.com/116387786/233704530-064287a4-f2f8-4b44-90fc-4602f62a88fd.png)

The top properties are for the scrolling texture while the bottom ones are for the water shader.

![image](https://user-images.githubusercontent.com/116387786/233704851-b2553f4c-a836-4d33-a0b0-7a337d4fafdc.png)

I made sure to add the vertex portion to be able to include the water shader vertex displacement effect.

![image](https://user-images.githubusercontent.com/116387786/233704947-f2ce276b-fcbc-4117-8823-52580939e423.png)

The rest was fairly easy, as all I had to do was to put the scrolling text shader into the surf shader method, and the water shader into the vert method.

![image](https://user-images.githubusercontent.com/116387786/233705082-d7e93de0-9406-4d8a-8323-4c14199d3aa9.png)

As the final step, I created the "LavaSwitch" script, which switches the speed of the lava scrolling texture.
The toggle for this one if the "P" key (press the key twice for the effect to show up the first time, not sure why this happens but I tried fixing it by switching the bool's parity, didn't work).
The code is a simple if statement that changes the speed based on what the bool is set to after pressing "P".

![image](https://user-images.githubusercontent.com/116387786/233706491-4c25612f-90d6-4e42-ab87-33a769a9f46b.png)



## Bump

![image](https://user-images.githubusercontent.com/116387786/233705648-28f49c8f-65c9-4d0b-a750-4b238105a67b.png)

This one was also fairly simple, as the main change I did to the Bump shader code was simply add a color to it.
I decided to do this and not something else because the lava/fire acts like a light source, meaning that the background would naturally have a red tint to it (this can be modified via the inspector.

![image](https://user-images.githubusercontent.com/116387786/233705910-5f430635-4979-405c-8058-75b889797525.png)

All that was needed to do this was the color property, instantiating it in the subshader, and setting it's albedo value to the color.

![image](https://user-images.githubusercontent.com/116387786/233706871-661fe935-195e-4318-b5e8-739c3e6b595b.png)
![image](https://user-images.githubusercontent.com/116387786/233707065-927e4df6-301c-4b5a-8f4a-f247a8e5ae36.png)



## Bloom

This one was an interesting one to make.

Essentially what I did was take the bloom shader and C# scripts from the lecture and proceed as normal.
However, I added a bit to the C# script that would use an animation curve to make the "threshold" variable of the bloom effect to pulsate over time, giving it a sort of 'low health' urgency feeling. Of course this was a bit exaggerated to make the effect visible.

I created a bunch of variables in the Bloon C# script that include a max and min value, time, a bool (which isn't needed, I just forgot to remove it), and an animation curve.
Then, in an update function, I made it so that the threshold value would change according to the time value, which is following a ping pong animatio curve.

![image](https://user-images.githubusercontent.com/116387786/233707746-e2246a87-37cb-4982-ba53-19dc309cf17a.png)
![image](https://user-images.githubusercontent.com/116387786/233707785-f50f6aba-5cfd-4d4b-abe8-ecbb979b3fa8.png)
![image](https://user-images.githubusercontent.com/116387786/233708416-5d37dcea-8cf9-4626-b2c9-10fe1cf4d0ff.png)

Finally, I created the simple "BloomManager" script and also put it on the camera, all this does is that it allows toggling by activating and deactivating the script.
The toggle for this one is the "O" key.

![image](https://user-images.githubusercontent.com/116387786/233708779-2cabd761-f652-46ba-9f3b-5a3673aec801.png)

With Bloom:

![image](https://user-images.githubusercontent.com/116387786/233712189-c338c210-f766-4dd6-882a-f1190f3b267f.png)

Without Bloom:

![image](https://user-images.githubusercontent.com/116387786/233712224-5cc18979-95c8-4a9b-a768-4dc88e668642.png)


## Extra

These are where the extra stuff are explained.

1. The movement was done using a simple WASD movement script that clamps the player's position to not touch the lava.

![image](https://user-images.githubusercontent.com/116387786/233709246-8dd028ba-3537-4e62-a97d-871503722df7.png)

2. The light moving was done by creating an empty, making the directional light a child of that empty (with a slight positional offset), then a simple rotation script rotating the empty object.

![image](https://user-images.githubusercontent.com/116387786/233709298-ab45d52a-4ea6-47c0-8d0c-983cfeae6e89.png)
